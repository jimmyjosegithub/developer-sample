import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);

  const handleLogin = ({login, password}) => {
    if(login.trim() !== "" && password.trim() !== "") {
      const data = {login, password};
      setLoginAttempts([...loginAttempts, data]);
    }
    document.getElementById("name").value = "";
    document.getElementById("password").value = "";
  }
 
   return (
    <div className="App">
    <LoginForm onSubmit={handleLogin} />
    <LoginAttemptList attempts={loginAttempts}  />
    </div>
  );
};

export default App;
