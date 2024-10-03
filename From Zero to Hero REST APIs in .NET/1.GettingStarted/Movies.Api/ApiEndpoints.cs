using System;

namespace Movies.Api;

public static class ApiEndpoints
{
    private const string ApiBase = "api";

    public static class Movies
    {
        // base endpoint
        private const string Base = ApiBase + "/movies";

        // create a movie (POST)
        public const string Create = Base;

        // get by id (GET)
        public const string Get = Base + "/{id}";

        // get all (GET)
        public const string GetAll = Base;

        // update (PUT)
        public const string Update = Base + "/{id}";

        // delete (DELETE)
        public const string Delete = Base + "/{id}";
    }
}
