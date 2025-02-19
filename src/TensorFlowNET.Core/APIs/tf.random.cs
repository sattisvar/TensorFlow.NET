﻿/*****************************************************************************
   Copyright 2018 The TensorFlow.NET Authors. All Rights Reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
******************************************************************************/

namespace Tensorflow
{
    public partial class tensorflow
    {
        /// <summary>
        /// Outputs random values from a normal distribution.
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="mean"></param>
        /// <param name="stddev"></param>
        /// <param name="dtype"></param>
        /// <param name="seed"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Tensor random_normal(int[] shape,
            float mean = 0.0f,
            float stddev = 1.0f,
            TF_DataType dtype = TF_DataType.TF_FLOAT,
            int? seed = null,
            string name = null) => random_ops.random_normal(shape, mean, stddev, dtype, seed, name);

        public Tensor random_uniform(int[] shape,
            float minval = 0,
            float maxval = 1,
            TF_DataType dtype = TF_DataType.TF_FLOAT,
            int? seed = null,
            string name = null) => random_ops.random_uniform(shape, minval, maxval, dtype, seed, name);

        public Tensor truncated_normal(int[] shape,
            float mean = 0.0f,
            float stddev = 1.0f,
            TF_DataType dtype = TF_DataType.TF_FLOAT,
            int? seed = null,
            string name = null)
            => random_ops.truncated_normal(shape, mean, stddev, dtype, seed, name);
    }
}
