﻿//  *******************************************************************************
//  *  Licensed under the Apache License, Version 2.0 (the "License");
//  *  you may not use this file except in compliance with the License.
//  *  You may obtain a copy of the License at
//  *
//  *  http://www.apache.org/licenses/LICENSE-2.0
//  *
//  *   Unless required by applicable law or agreed to in writing, software
//  *   distributed under the License is distributed on an "AS IS" BASIS,
//  *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  *   See the License for the specific language governing permissions and
//  *   limitations under the License.
//  ******************************************************************************

namespace NmeaParser.Gnss.Ntrip
{
    /// <summary>
    /// Enumeration for the carrier used by the <see cref="NtripStream"/>
    /// </summary>
    public enum Carrier : int
    {
        /// <summary>
        /// None / unknown
        /// </summary>
        None = 0,

        /// <summary>
        /// L1 wave
        /// </summary>
        L1 = 1,

        /// <summary>
        /// L1 and L2 waves
        /// </summary>
        L1L2 = 2
    }
}
