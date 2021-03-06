﻿using System.Threading.Tasks;
using IdentityModel.Client;

namespace PSC.BaseApiSDK
{
    public class UserCredentialsTokenAuthClient
    {
        private readonly string _endpoint;
        private readonly string _clientId;
        private readonly string _clientSecret;

        protected TokenResponse TokenResponse;

        public UserCredentialsTokenAuthClient(string endpoint, string clientId, string clientSecret)
        {
            _endpoint = endpoint;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        public async Task<TokenResponse> AuthAsync(string username, string password, string targetClientId)
        {
            DiscoveryResponse discoveryResponse = await DiscoveryClient.GetAsync(_endpoint);

            TokenClient tokenClient = new TokenClient(discoveryResponse.TokenEndpoint, _clientId, _clientSecret);
            TokenResponse response = await tokenClient.RequestResourceOwnerPasswordAsync(username, password, targetClientId);

            if (response.IsError)
            {
                throw new HttpApiTokenResponseFailedException(response.Error);
            }

            return response;
        }
    }
}