using EFCwithWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCwithWebAPI.Services
{
    internal interface ISentenceService
    {
        IEnumerable<SentenceHolder> GetAll();
        void AddSentence(SentenceHolder sentence);
    }
}
