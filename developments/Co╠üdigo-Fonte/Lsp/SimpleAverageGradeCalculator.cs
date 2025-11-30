namespace SolidPrinciples.Lsp
{
    public class SimpleAverageGradeCalculator : IAverageGradeCalculator
    {
        public string Subject { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }

        public SimpleAverageGradeCalculator(string subject, int year, int semester)
        {
            Subject = subject;
            Year = year;
            Semester = semester;
        }

        public virtual double Calculate(int[] grades) {
            var average = Math.Floor(grades.Average());

            Console.WriteLine($"Matéria: {Subject} do período {Semester}/{Year} é: {average}");

            return average;
        }
    }
}