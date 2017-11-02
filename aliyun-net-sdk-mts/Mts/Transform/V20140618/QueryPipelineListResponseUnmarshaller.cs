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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QueryPipelineListResponseUnmarshaller
    {
        public static QueryPipelineListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPipelineListResponse queryPipelineListResponse = new QueryPipelineListResponse();

			queryPipelineListResponse.HttpResponse = context.HttpResponse;
			queryPipelineListResponse.RequestId = context.StringValue("QueryPipelineList.RequestId");

			List<string> nonExistPids = new List<string>();
			for (int i = 0; i < context.Length("QueryPipelineList.NonExistPids.Length"); i++) {
				nonExistPids.Add(context.StringValue("QueryPipelineList.NonExistPids["+ i +"]"));
			}
			queryPipelineListResponse.NonExistPids = nonExistPids;

			List<QueryPipelineListResponse.Pipeline> pipelineList = new List<QueryPipelineListResponse.Pipeline>();
			for (int i = 0; i < context.Length("QueryPipelineList.PipelineList.Length"); i++) {
				QueryPipelineListResponse.Pipeline pipeline = new QueryPipelineListResponse.Pipeline();
				pipeline.Id = context.StringValue("QueryPipelineList.PipelineList["+ i +"].Id");
				pipeline.Name = context.StringValue("QueryPipelineList.PipelineList["+ i +"].Name");
				pipeline.State = context.StringValue("QueryPipelineList.PipelineList["+ i +"].State");
				pipeline.Speed = context.StringValue("QueryPipelineList.PipelineList["+ i +"].Speed");
				pipeline.Role = context.StringValue("QueryPipelineList.PipelineList["+ i +"].Role");

				QueryPipelineListResponse.Pipeline.NotifyConfig_ notifyConfig = new QueryPipelineListResponse.Pipeline.NotifyConfig_();
				notifyConfig.Topic = context.StringValue("QueryPipelineList.PipelineList["+ i +"].NotifyConfig.Topic");
				notifyConfig.QueueName = context.StringValue("QueryPipelineList.PipelineList["+ i +"].NotifyConfig.QueueName");
				pipeline.NotifyConfig = notifyConfig;

				pipelineList.Add(pipeline);
			}
			queryPipelineListResponse.PipelineList = pipelineList;
        
			return queryPipelineListResponse;
        }
    }
}