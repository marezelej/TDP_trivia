namespace TP_Final.Domain
{
    /// <summary>
    /// Una respuesta a una pregunta
    /// </summary>
    internal class Answer
    {
        int Id { get; set; }
        string Description { get; set; }
        Question Question { get; set; }
    }
}