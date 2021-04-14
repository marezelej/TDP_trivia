using System;
using System.Collections.Generic;

namespace TriviaGame.Domain
{
    /// <summary>
    /// Una sesión de preguntas
    /// </summary>
    public class Session
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public float Score { get; set; }
        public int Time { get; set; }
        public DateTime Timestamp { get; set; }
        public Session()
        {
        }
        public Session(User pUser, float pScore, int pTime)
        {
            User = pUser;
            Score = pScore;
            Time = pTime;
            Timestamp = DateTime.Now;
        }
    }
}