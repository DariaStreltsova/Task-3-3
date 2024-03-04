using System;


namespace Interface
{
    public abstract class BaseClass : IBase{
        protected abstract void UserInput();
        protected abstract void RandomInput();
        public abstract void Print();
        public abstract void average();
        protected void Choice(bool InputByUser){
            if(!InputByUser){
                RandomInput();
            }
            else{
                UserInput();
            }
        }
    }
}