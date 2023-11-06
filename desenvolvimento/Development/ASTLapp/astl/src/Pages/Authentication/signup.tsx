
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

function SignUp() {
  return (
    <section className="container forms">
    <div className="form login">
        <div className="form-content">
            <header>Logar</header>
            <form action="#">
                <div className="field input-field">
                    <input type="email" placeholder="Email" className="input" />
                </div>

                <div className="field input-field">
                    <input type="password" placeholder="Senha" className="password" />
                    <i className='bx bx-hide eye-icon'></i>
                </div>

                <div className="form-link">
                    <a href="#" className="forgot-pass">Esqueceu a senha?</a>
                </div>

                <div className="field button-field">
                    <button>Entrar</button>
                </div>
            </form>

            <div className="form-link">
                <span>Não consegue acessar a conta? <a href="/signin" className="link signup-link">Cadastrar-se</a></span>
            </div>
        </div>

        <div className="line"></div>

        <div className="media-options">
            <a href="#" className="field facebook">
                {/* <i className='bx bxl-facebook facebook-icon'></i> */}
                <img src={githubImg}  alt="" className="github-img" />
                <span>Acesse com o GitHub</span>
            </a>
        </div>

        <div className="media-options">
            <a href="#" className="field google">
                <img src={googleImg}  alt="" className="google-img" />
                <span>Acesse com o Google</span>
            </a>
        </div>
    </div>

</section>
  );
}

export default SignUp;
