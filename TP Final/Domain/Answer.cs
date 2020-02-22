namespace TriviaGame.Domain
{
    /// <summary>
    /// Una respuesta a una pregunta
    /// </summary>
    public class Answer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
    }
}