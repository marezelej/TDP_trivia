namespace TP_Final.Domain
{
    /// <summary>
    /// Una respuesta a una pregunta
    /// </summary>
    internal class Answer
    {
        internal int Id { get; set; }
        internal string Description { get; set; }
        internal bool IsCorrect { get; set; }
        internal Question Question { get; set; }
    }
}