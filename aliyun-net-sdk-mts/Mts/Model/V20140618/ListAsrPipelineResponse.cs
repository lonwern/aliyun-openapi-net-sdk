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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class ListAsrPipelineResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<ListAsrPipeline_Pipeline> pipelineList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListAsrPipeline_Pipeline> PipelineList
		{
			get
			{
				return pipelineList;
			}
			set	
			{
				pipelineList = value;
			}
		}

		public class ListAsrPipeline_Pipeline
		{

			private string id;

			private string name;

			private string state;

			private string priority;

			private ListAsrPipeline_NotifyConfig notifyConfig;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public ListAsrPipeline_NotifyConfig NotifyConfig
			{
				get
				{
					return notifyConfig;
				}
				set	
				{
					notifyConfig = value;
				}
			}

			public class ListAsrPipeline_NotifyConfig
			{

				private string topic;

				private string queueName;

				public string Topic
				{
					get
					{
						return topic;
					}
					set	
					{
						topic = value;
					}
				}

				public string QueueName
				{
					get
					{
						return queueName;
					}
					set	
					{
						queueName = value;
					}
				}
			}
		}
	}
}