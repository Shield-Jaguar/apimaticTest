# -*- coding: utf-8 -*-

"""
youtube

This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
"""

from youtube.api_helper import APIHelper
from youtube.configuration import Server
from youtube.controllers.base_controller import BaseController
from youtube.exceptions.problem_details_exception import ProblemDetailsException
from youtube.exceptions.api_exception import APIException


class APIController(BaseController):

    """A Controller to access Endpoints in the youtube API."""

    def __init__(self, config, call_back=None):
        super(APIController, self).__init__(config, call_back)

    def get_forcast(self,
                    param='String.Empty'):
        """Does a GET request to /WeatherForecast.

        get list of 5 random forcasts

        Args:
            param (string, optional): default string parameter

        Returns:
            mixed: Response from the API.

        Raises:
            APIException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        # Prepare query URL
        _url_path = '/WeatherForecast'
        _query_builder = self.config.get_base_uri(Server.DEFAULT)
        _query_builder += _url_path
        _query_parameters = {
            'param': param
        }
        _query_builder = APIHelper.append_url_with_query_parameters(
            _query_builder,
            _query_parameters
        )
        _query_url = APIHelper.clean_url(_query_builder)

        # Prepare headers
        _headers = {
            'accept': 'application/json'
        }

        # Prepare and execute request
        _request = self.config.http_client.get(_query_url, headers=_headers)
        _response = self.execute_request(_request)

        # Endpoint and global error handling using HTTP status codes.
        if _response.status_code == 400:
            raise ProblemDetailsException('Test error message', _response)
        elif _response.status_code == 404:
            raise APIException('not found', _response)
        self.validate_response(_response)
        if (_response.text is not None) or (not str(_response.text)):
            decoded = APIHelper.json_deserialize(_response.text)

        return decoded