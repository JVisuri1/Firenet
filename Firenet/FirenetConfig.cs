using System;
using System.Collections.Generic;
using System.Text;

namespace Firenet
{
    /// <summary>
    /// Firenet configuration class
    /// </summary>
    public class FirenetConfig
    {
        /// <summary>
        /// Firebase access token
        /// </summary>
        public string token { get; private set; }

        /// <summary>
        /// Firebase address
        /// </summary>
        public string rootPath { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_token"></param>
        /// <param name="_path"></param>
        public FirenetConfig(string _token, string _path)
        {
            token = _token;
            rootPath = _path;
        }
    }
}
