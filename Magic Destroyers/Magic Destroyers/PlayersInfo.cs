namespace Magic_Destroyers
{
    public static class PlayersInfo
    {
        // PlayersInfo Fields: ==========================================
        private static string playersInfoDirectory;
        private static string[,] fullInfo = new string[2, 6];
        private static string[,] scores = new string[1, 6];
        private static string[,] levels = new string[1, 6];



        // PlayersInfo Methods: ==========================================
        public static void Initialize()
        { }
        public static void Save() { }
        public static void UpdateFullInfo() { }
        public static void RetrieveFullInfo() { }
        public static void PrintFullInfo() { }
        public static void EraseFullInfo() { }
        public static void UpdateScores() { }
        public static void RetrieveScores() { }
        public static void PrintScores() { }
        public static void EraseScores() { }
        public static void UpdateLevels() { }
        public static void RetrieveLevels() { }
        public static void PrintLevels() { }
        public static void EraseLevels() { }
    }
}
