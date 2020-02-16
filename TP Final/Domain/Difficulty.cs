namespace TP_Final.Domain
{
    /// <summary>
    /// Una dificultad de preguntas
    /// </summary>
    internal class Difficulty
    {
        internal int Id { get; set; }
        internal string Description { get; set; }
        internal float Weight { get; set; }
        internal QuestionsSet Set { get; set; }
    }
}