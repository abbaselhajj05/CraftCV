namespace CVCraft.Services {
    public class ArithmeticService : IArithmeticService {
        public int Sum(params int[] numbers) {
            return numbers.Sum();
        }
    }
}
