import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <li {...props}>{props.children}</li>;

const LoginAttemptList = (props) => (
	<div className="Attempt-List-Main">
	 	<p>Recent activity</p>
	  	<input type="input" placeholder="Filter..." />
		<ul className="Attempt-List">
			{props.attempts.map((attempt, ind) => (
				<LoginAttempt key={ind}>
					<div>Login: {attempt.login}</div>
					<div>Password: {attempt.password}</div></LoginAttempt>

			))}
			
		</ul>
	</div>
);

export default LoginAttemptList;