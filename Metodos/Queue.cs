using System;

namespace Pilha.Metodos
{
    public class Queue
    {
        Position Last;

        public void StackUp(object item) 
        {
            Last = new Position(Last, item);
        }

        public object UnStack() 
        {
            if(Last == null)
            {
                throw new InvalidOperationException("A pilha está vazia.");
            }

            object resultado = Last.item;
            Last = Last.Before;
            return resultado;

        }

        class Position
        {
            public Position Before;

            public object item;

            public Position(Position Before, object item)
            {
                this.Before = Before;
                this.item = item;
            }   
        }
    }
}