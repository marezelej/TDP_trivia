using System;
using System.Collections.Generic;

namespace TP_Final.Dominio
{
    internal class Session
    {
        int Id { get; set; }
        int UserId { get; set; }
        int Score { get; set; }
        int Quantity { get; set; }
        TimeSpan Time { get; set; }
        Set Set { get; set; }
        Category Category { get; set; }
        Difficulty Difficulty { get; set; }
        IList<Question> Questions { get; set; }
    }
}