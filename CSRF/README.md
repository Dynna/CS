## CSRF anti attack login based on double submit cookie pattern.

A WEB application that implements CSRF protection on the user authentication.

## Table of Contents
* [General info](#general-info)
* [Double Submit Cookie Pattern - How it works](#double-submit-cookie-pattern-how-it-works)
* [Technologies](#technologies)
* [Setup](#setup)
## General info
One of the very dangerous attacks that an adversary can perform is a Cross-Site Request Forgery (CSRF) attack. A CSRF attack allows the adversary to perform unwanted actions on
a web application in which a user is currently authenticated. CSRF attacks bring the most damage when executed by a logged user (especially an admin). To summarize we have to:
* Create a web application where the user can authenticate;
* Implement CSRF protection for your web application;
* Prove the effectiveness of implemented mechanisms (via video)
## Double Submit Cookie Pattern - How it works
When a user authenticates to a site, the site should generate a session identifier and set a cookie in the browser. At the same time, it generates the cryptographically strong random value or the CSRF token for the session and set it as a cookie on the user’s machine separate from the session id. The server does not have to save this value in any way, that’s why this pattern is sometimes also called Stateless CSRF Defense.
The site then requires that every request include this random value as a hidden form value (or another request parameter). A cross-origin attacker cannot read any data sent from the server or modify cookie values, per the same-origin policy.
When the user clicks “updatepost” btn the Post request is sent. Then the server validates the cookie header for session id and also server compares CSRF token from request body(hidden field value) against CSRF token from the header cookie. If these tokens matched then server accepts the request.
Cookies are sent automatically with every request, regardless of whether the request was initiated by the original site or by a third party site. That’s why a cookie alone does not suffice as every request will contain it.
But by having the token also in the request itself, an attacking site cannot generate valid requests anymore as they can’t get hold on the user’s token. 
## Technologies
Project is created with:
* PHP, HTML, CSS
* PHPStorm
* XAMPP 
## Setup
To run this project, clone it and open using PHPStorm or another code editor that supports php, then run the server on xampp and open the index.php .

