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
        public Tensor convert_to_tensor(object value, TF_DataType dtype = TF_DataType.DtInvalid, string name = null, TF_DataType preferred_dtype = TF_DataType.DtInvalid) 
            => ops.convert_to_tensor(value, dtype, name, preferred_dtype);

        public Tensor strided_slice(Tensor input, Tensor begin, Tensor end, Tensor strides = null,
            int begin_mask = 0,
            int end_mask = 0,
            int ellipsis_mask = 0,
            int new_axis_mask = 0,
            int shrink_axis_mask = 0,
            string name = null) => gen_array_ops.strided_slice(input: input,
                begin: begin,
                end: end,
                strides: strides,
                begin_mask: begin_mask,
                end_mask: end_mask,
                ellipsis_mask: ellipsis_mask,
                new_axis_mask: new_axis_mask,
                shrink_axis_mask: shrink_axis_mask,
                name: name);

        public Tensor strided_slice<T>(Tensor input, T[] begin, T[] end, T[] strides = null,
            int begin_mask = 0,
            int end_mask = 0,
            int ellipsis_mask = 0,
            int new_axis_mask = 0,
            int shrink_axis_mask = 0,
            string name = null) => gen_array_ops.strided_slice(input: input,
                begin: begin,
                end: end,
                strides: strides,
                begin_mask: begin_mask,
                end_mask: end_mask,
                ellipsis_mask: ellipsis_mask,
                new_axis_mask: new_axis_mask,
                shrink_axis_mask: shrink_axis_mask,
                name: name);
    }
}
