/*
 * YoutubeLib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

package localhost5001;

import java.io.IOException;
import java.util.concurrent.CompletableFuture;
import localhost5001.exceptions.ApiException;
import localhost5001.http.request.HttpRequest;

/**
 * Interface for defining the behavior of Authentication Classes.
 */
public interface AuthManager {

    /**
     * Adds authentication to the given HttpRequest.
     * @param httpRequest   HttpRequest object for authentication
     * @return Returns the object of HttpRequest
     * @throws ApiException   Represents error response from the server.
     * @throws IOException   Signals that an I/O exception of some sort has occurred.
     */
    HttpRequest apply(HttpRequest httpRequest) throws ApiException, IOException;

    /**
     * Asynchronously adds authentication to the given HttpRequest.
     * @param httpRequest   HttpRequest object for authentication
     * @return Returns the completable future of HttpRequest
     */
    CompletableFuture<HttpRequest> applyAsync(HttpRequest httpRequest);
}
