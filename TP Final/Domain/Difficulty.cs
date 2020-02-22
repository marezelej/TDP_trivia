namespace TriviaGame.Domain
{
    /// <summary>
    /// Una dificultad de preguntas
    /// </summary>
    public class Difficulty
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
    }
}