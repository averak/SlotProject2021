namespace SlotProject
{

    public class ReelModel
    {

        private SymbolType[] symbols;

        private bool isSpinning = false;

        public ReelModel()
        {
            // 図柄リストを定義
            this.symbols = new SymbolType[] {
                SymbolType.SEVEN,
                SymbolType.FULLHD,
                SymbolType.WATERMELON,
                SymbolType.BAR,
                SymbolType.REPLAY,
                SymbolType.CHERRY,
                SymbolType.SEVEN,
                SymbolType.FULLHD,
                SymbolType.WATERMELON,
                SymbolType.BAR,
                SymbolType.REPLAY,
                SymbolType.CHERRY,
           };
        }

        // 図柄一覧を取得
        public SymbolType[] getSymbols()
        {
            return this.symbols;
        }

        // 図柄の数を取得
        public int getLength()
        {
            return this.symbols.Length;
        }

        // 回転開始
        public void start() {
            this.isSpinning = true;
        }

        // 回転停止
        public void stop() {
            this.isSpinning = false;
        }

    }

}
