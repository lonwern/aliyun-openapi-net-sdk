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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = context.HttpResponse;
			describeAccountsResponse.RequestId = context.StringValue("DescribeAccounts.RequestId");

			List<DescribeAccountsResponse.DescribeAccounts_Account> describeAccountsResponse_accounts = new List<DescribeAccountsResponse.DescribeAccounts_Account>();
			for (int i = 0; i < context.Length("DescribeAccounts.Accounts.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_Account account = new DescribeAccountsResponse.DescribeAccounts_Account();
				account.DBInstanceId = context.StringValue("DescribeAccounts.Accounts["+ i +"].DBInstanceId");
				account.AccountName = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountName");
				account.AccountStatus = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountStatus");
				account.AccountDescription = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountDescription");

				describeAccountsResponse_accounts.Add(account);
			}
			describeAccountsResponse.Accounts = describeAccountsResponse_accounts;
        
			return describeAccountsResponse;
        }
    }
}