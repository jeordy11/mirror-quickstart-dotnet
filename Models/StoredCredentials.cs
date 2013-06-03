﻿/*
 * Copyright (c) 2013 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MirrorQuickstart.Models
{
    public class StoredCredentials
    {
        [Key]
        public string UserId { get; set; }

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }

    public class StoredCredentialsDBContext : DbContext
    {
        public DbSet<StoredCredentials> StoredCredentialSet { get; set; }
    }

    public class StoredCredentialsInitializer :
        DropCreateDatabaseIfModelChanges<StoredCredentialsDBContext>
    {
    }
}