﻿using AspNetMvcRateLimit.Models;

namespace AspNetMvcRateLimit.Store
{
    public interface IClientPolicyStore
    {
        bool Exists(string id);
        ClientRateLimitPolicy Get(string id);
        void Remove(string id);
        void Set(string id, ClientRateLimitPolicy policy);
    }
}