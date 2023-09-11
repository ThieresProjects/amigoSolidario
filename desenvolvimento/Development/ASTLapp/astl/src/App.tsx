import React from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="container">
        {/* <!-- Login Form--> */}
        <div className="login-form">
            <div className="title">Login</div>
            <form action="#">
                {/* <!-- E-mail --> */}
                <div className="input-box">
                    <i className="fa fa-envelope"></i>
                    <input type='text' placeholder='E-mail' required />
                </div>
                {/* <!-- Password --> */}
                <div className="input-box">
                    <i className="fa fa-lock"></i>
                    <input type="password" placeholder="Senha" required />
                </div>
                {/* <!-- Forgot Password --> */}
                <div className="forgot"><a href="#">Esqueceu a sua senha?</a></div>
                {/* <!-- Enter --> */}
                <div className="input-box">
                    <input type="submit" value="Entrar" />
                </div>
                <div className="signup-text">
                    Não tem uma conta? <a href="sign up.html">Crie uma agora!</a>
                </div>
            </form>
        </div>
        {/* <!-- End of Login --> */}
    </div>
  );
}

export default App;
