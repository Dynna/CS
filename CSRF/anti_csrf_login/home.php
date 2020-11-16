<?php

require_once 'token.php';

if(isset($_POST['updatepost'])){
		echo "SERVER REQUEST ACCEPTED: ".$_POST['updatepost'] . " || CSRF token match cookie == (" . $_POST["token"] . ") with hidden field == (" . $_COOKIE['csrfTokenCookie'] . ")";
	} else {
	    echo "SERVER REQUEST FAIL! SOMEONE TRIES TO HACK YOU!! Unauthorized request: ".$_COOKIE['csrfTokenCookie'];
}
