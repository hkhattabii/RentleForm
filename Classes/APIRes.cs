using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentleForm.Classes
{
    abstract public class Res
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public Res(string Message, bool Success)
        {
            this.Message = Message;
            this.Success = Success;
        }
    }
    public class APIRes : Res
    {
        public APIRes(string Message, bool Success) : base(Message, Success)
        {

        }
    }

    public class APIRes<TEntity> : Res
    {
        public TEntity Entity { get; set; }
        public APIRes(string Message, bool Success, TEntity Entity) : base(Message, Success)
        {
            this.Entity = Entity;
        }
    }
}
