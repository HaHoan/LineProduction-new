using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Business
{
    public static class ValidateCommon
    {
        public static string ValidateRule(string ruleNo, string serial)
        {
            try
            {
                var rule = WIPHelper.pvsservice.GetBarodeRuleItemsByRuleNo(ruleNo);
                if (rule == null)
                {
                    var strArr = ruleNo.Split('-');
                    if (strArr.Length == 1) return "Liên hệ với IT để thiết lập rule cho model này";
                    var replaceModel = strArr[0] + "-" + strArr[1];
                    rule = WIPHelper.pvsservice.GetBarodeRuleItemsByRuleNo(replaceModel);
                    if (rule == null)
                        return "Liên hệ với IT để thiết lập rule cho model này";
                }

                if (rule.LOCATION is int location && rule.CONTENT_LENGTH is int content_length &&
                    Strings.Mid(serial, location, content_length) == rule.CONTENT && serial.Length == rule.LENGTH)
                {
                    return "OK";
                }
                return serial + " có mã quy định là " + rule.CONTENT;
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }

        }
        public static string ValidateBox(string macBox, string ModelCurrent)
        {
            try
            {
                var model = USAPHelper.usapservice.GetByBcNo(macBox);
                if (model == null) return "Mác thùng không tồn tại";
                if (model.PART_NO != ModelCurrent) return "Box thuộc model " + model.PART_NO;
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public static string ValidateSerial(List<string> serials, string ModelCurrent, bool IsUsingWip)
        {
            var checkRule = "";
          
            foreach (var serial in serials)
            {
                if (!IsUsingWip) return ValidateRule(ModelCurrent, serial);
                // Check nhầm model
                var boardInfo = WIPHelper.pvsservice.GetBoards(serial);
                if (boardInfo == null)
                {
                    checkRule = ValidateRule(ModelCurrent, serial);
                    if (checkRule == "OK")
                    {
                        break;
                    }
                    else return checkRule;
                }
                if (boardInfo.PRODUCT_ID != ModelCurrent)
                {
                    return "Serial thuộc Model " + boardInfo.PRODUCT_ID;
                }

                // Check nhầm công đoạn
                var orderItem = WIPHelper.pvsservice.GetWorkOrderItemByBoardNo(serial);

                if (orderItem == null)
                {
                    checkRule = ValidateRule(ModelCurrent, serial);
                    if (checkRule == "OK")
                    {
                        break;
                    }
                    else return checkRule;
                }
                var proceduces = WIPHelper.pvsservice.GetWorkOrderProcedureByOrderId(orderItem.ORDER_ID.ToString());
                if (proceduces == null)
                {
                    checkRule = ValidateRule(ModelCurrent, serial);
                    if (checkRule == "OK")
                    {
                        break;
                    }
                    else return checkRule;
                }
                var requireStation = proceduces.Where(m => m.STATION_NAME == Common.GetValueRegistryKey(Constants.PathConfig, RegistryKeys.station)).FirstOrDefault();
                if (requireStation == null) return "Kiểm tra lại tên trạm";
                if (orderItem.PROCEDURE_INDEX < (requireStation.INDEX - 1))
                {
                    var currentStation = proceduces.Where(m => m.INDEX == (orderItem.PROCEDURE_INDEX + 1)).FirstOrDefault();
                    return "Mạch đang ở trạm " + currentStation.STATION_NAME;
                }
                checkRule = ValidateRule(requireStation.RULE_NO, serial);
            }
            return checkRule;
        }
    }
}
