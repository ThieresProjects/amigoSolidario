
import './styles.css';
import googleImg from '../../Content/Img/google.png'
import githubImg from '../../Content/Img/github.png'

// const forms = document.querySelector(".forms"),
//       pwShowHide = document.querySelectorAll(".eye-icon"),
//       links = document.querySelectorAll(".link");

// pwShowHide.forEach( (eyeIcon:any) => {
//     eyeIcon.addEventListener("click", () => {
//         let pwFields = eyeIcon.parentElement.parentElement.querySelectorAll(".password");
        
//         pwFields.forEach( (password:any) => {
//             if(password.type === "password"){
//                 password.type = "text";
//                 eyeIcon.classList.replace("bx-hide", "bx-show");
//                 return;
//             }
//             password.type = "password";
//             eyeIcon.classList.replace("bx-show", "bx-hide");
//         })
        
//     })
// })      

// links.forEach(link => {
//     link.addEventListener("click", e => {
//        e.preventDefault(); //preventing form submit
//        forms?.classList.toggle("show-signup");
//     })
// })

function SignIn() {
  return (
    <section className="container forms">

    <div className="form signin">
        <div className="form-content">
            <header>Cadastrar-se</header>
            <form action="#">
                <div className="field input-field">
                    <input type="email" placeholder="Email" className="input" />
                </div>

                <div className="field input-field">
                    <input type="password" placeholder="Senha" className="password" />
                </div>

                <div className="field input-field">
                    <input type="password" placeholder="Confirme sua senha" className="password" />
                    <i className='bx bx-hide eye-icon'></i>
                </div>

                <div className="field button-field">
                    <button>Cadastrar</button>
                </div>
            </form>

            <div className="form-link">
                <span>Já tem uma conta? <a href="/" className="link login-link">Logar</a></span>
            </div>
        </div>

        <div className="line"></div>

        <div className="media-options">
            <a href="#" className="field facebook">
                <img src={githubImg}  alt="" className="github-img" />
                <span>Entrar com o GitHub</span>
            </a>
        </div>

        <div className="media-options">
            <a href="#" className="field google">
                <img src={googleImg} alt="" className="google-img" />
                <span>Entrar com o Google</span>
            </a>
        </div>

        </div>
    </section>
  );
}

export default SignIn;
