﻿// Copyright 2012-2016 Chris Patterson
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Authority.Runtime
{
    using System.Threading.Tasks;


    public interface IFactSink :
        IAcceptVisitor
    {
        Task Insert<T>(FactContext<T> context)
            where T : class;
    }


    /// <summary>
    /// A target for facts that are being propogated forward
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFactSink<in T> :
        IAcceptVisitor
        where T : class
    {
        /// <summary>
        /// Insert a fact into the sink
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        Task Insert(FactContext<T> context);
    }
}