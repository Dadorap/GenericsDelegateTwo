using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDelegateTwo
{
    public delegate TOutput FilterTransformDelegate<TInput,TOutput>(TInput input);
        
   
}
