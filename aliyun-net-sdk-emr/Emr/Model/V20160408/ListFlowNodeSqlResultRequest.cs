/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class ListFlowNodeSqlResultRequest : RpcAcsRequest<ListFlowNodeSqlResultResponse>
    {
        public ListFlowNodeSqlResultRequest()
            : base("Emr", "2016-04-08", "ListFlowNodeSqlResult", "emr", "openAPI")
        {
        }

		private int? offset;

		private string regionId;

		private int? length;

		private int? sqlIndex;

		private string nodeInstanceId;

		private string projectId;

		public int? Offset
		{
			get
			{
				return offset;
			}
			set	
			{
				offset = value;
				DictionaryUtil.Add(QueryParameters, "Offset", value.ToString());
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public int? Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value.ToString());
			}
		}

		public int? SqlIndex
		{
			get
			{
				return sqlIndex;
			}
			set	
			{
				sqlIndex = value;
				DictionaryUtil.Add(QueryParameters, "SqlIndex", value.ToString());
			}
		}

		public string NodeInstanceId
		{
			get
			{
				return nodeInstanceId;
			}
			set	
			{
				nodeInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "NodeInstanceId", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

        public override ListFlowNodeSqlResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListFlowNodeSqlResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
