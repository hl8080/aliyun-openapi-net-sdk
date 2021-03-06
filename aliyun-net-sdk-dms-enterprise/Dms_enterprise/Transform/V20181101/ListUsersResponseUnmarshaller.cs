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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext context)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = context.HttpResponse;
			listUsersResponse.RequestId = context.StringValue("ListUsers.RequestId");
			listUsersResponse.Success = context.BooleanValue("ListUsers.Success");
			listUsersResponse.ErrorMessage = context.StringValue("ListUsers.ErrorMessage");
			listUsersResponse.ErrorCode = context.StringValue("ListUsers.ErrorCode");
			listUsersResponse.TotalCount = context.LongValue("ListUsers.TotalCount");

			List<ListUsersResponse.ListUsers_User> listUsersResponse_userList = new List<ListUsersResponse.ListUsers_User>();
			for (int i = 0; i < context.Length("ListUsers.UserList.Length"); i++) {
				ListUsersResponse.ListUsers_User user = new ListUsersResponse.ListUsers_User();
				user.UserId = context.StringValue("ListUsers.UserList["+ i +"].UserId");
				user.Uid = context.LongValue("ListUsers.UserList["+ i +"].Uid");
				user.NickName = context.StringValue("ListUsers.UserList["+ i +"].NickName");
				user.Mobile = context.StringValue("ListUsers.UserList["+ i +"].Mobile");
				user.ParentUid = context.LongValue("ListUsers.UserList["+ i +"].ParentUid");
				user.State = context.StringValue("ListUsers.UserList["+ i +"].State");

				List<string> user_roleIdList = new List<string>();
				for (int j = 0; j < context.Length("ListUsers.UserList["+ i +"].RoleIdList.Length"); j++) {
					user_roleIdList.Add(context.StringValue("ListUsers.UserList["+ i +"].RoleIdList["+ j +"]"));
				}
				user.RoleIdList = user_roleIdList;

				List<string> user_roleNameList = new List<string>();
				for (int j = 0; j < context.Length("ListUsers.UserList["+ i +"].RoleNameList.Length"); j++) {
					user_roleNameList.Add(context.StringValue("ListUsers.UserList["+ i +"].RoleNameList["+ j +"]"));
				}
				user.RoleNameList = user_roleNameList;

				listUsersResponse_userList.Add(user);
			}
			listUsersResponse.UserList = listUsersResponse_userList;
        
			return listUsersResponse;
        }
    }
}
