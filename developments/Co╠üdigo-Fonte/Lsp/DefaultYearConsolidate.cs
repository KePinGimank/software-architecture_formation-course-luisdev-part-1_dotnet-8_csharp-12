namespace SolidPrinciples.Lsp
{
    public class DefaultYearConsolidateService
    {
        private readonly SimpleAverageGradeCalculator _calculator;
        public DefaultYearConsolidateService(SimpleAverageGradeCalculator averageGradeCalculator)
        {
            _calculator = averageGradeCalculator;
        }

        public void Consolidate()
        {
            _calculator.Calculate(new int[] { 1, 2, 3, 4 });
        }
    }

    public class SchoolService {
        public void ConsolidateClass() {
            var averageGradeCalculator = new SimpleAverageGradeCalculator("Portugues", 2022, 1);

            var defaultYearConsolidateService = new DefaultYearConsolidateService(averageGradeCalculator);

            defaultYearConsolidateService.Consolidate();
        }
    }
}