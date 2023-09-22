import React from "react";
import './LoginForm.css';

const LoginForm = (props) => {
	const handleSubmit = (event) =>{
		event.preventDefault();
		const login = document.getElementById("name").value;
    	const password = document.getElementById("password").value;
		props.onSubmit({
			login: login,
			password: password
		});
	}

	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" id="name" />
			<label htmlFor="password">Password</label>
			<input type="password" id="password" />
			<button type="submit" onClick={handleSubmit}>Continue</button>
		</form>
	)
}

export default LoginForm;