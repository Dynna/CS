# SSO - Single sign-on
# sso_auth - web application
A web application providing user authentication via SSO using 5 identity providers (Github, LinkedIn, Twitter, Facebook, Google);


## Table of Contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
## General info
This project goal is to be able to authenticate the user via SSO using some identity providers. After authenticating using one of those services, the
application outputs on screen data that it has been received from the identity providers. Using SSO in this application represents a secure alternative to classical authentication using login + passwords. On one hand it makes the life of the user much easier because they don’t need to remember yet another password. On the other hand, the security savvy users can get worried about what data is sent when using such logging systems. That's why the sso_auth application does the following:
* Offers user authentication via SSO using 5 identity providers (Github, LinkedIn, Twitter, Facebook, Google);
* Configures SSO integration to get as much as possible data about the end-user;
* Outputs all data which was provided by the identity providers.
## Technologies
Project is created with:
* JavaScript
* HTML
* Bootstrap
* XAMPP
* Apache server
## Setup
To run this project, clone the repository and open the file in any browse, but make sure to host it on a web server.
