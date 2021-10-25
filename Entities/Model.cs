﻿namespace Line_Production.Entities
{
    public partial class Model
    {
        public int Id { get; set; }
        public string ModelID { get; set; }
        public double Cycle { get; set; }
        public bool UseBarcode { get; set; }
        public bool CheckFirst { get; set; }
        public int NumberInModel { get; set; }
        public double WarnQuantity { get; set; }
        public double MinQuantity { get; set; }
        public int PersonInLine { get; set; }
        public string CharModel { get; set; }
        public int PCB { get; set; }
        public int ContentLength { get; set; }
        public int ContentIndex { get; set; }
        public string Customer { get; set; }
    }
    public static class ModelString
    {
        public static string Id = "Id";
        public static string ModelID = "Model";
        public static string PersonPerLine = "PersonPerLine";
        public static string CycleTime = "CycleTime";
        public static string WarnQuantity = "WarnQuantity";
        public static string MinQuantity = "MinQuantity";
        public static string CharModel = "CharModel";
        public static string UseBarcode = "UseBarcode";
        public static string NumberInModel = "NumberInModel";
        public static string PCB = "PCB";
        public static string Customer = "Customer";
        public static string ContentLength = "ContentLength";
        public static string ContentIndex = "ContentIndex";
        public static string CheckFirst = "CheckFirst";

    }
}
