import {Routes, Route} from "react-router-dom"

import Home from "../Pages/Home"
import SignUp from "../Pages/Authentication/signup"
import SignIn from "../Pages/Authentication/signin"

function MainRoutes(){
    return(
        <Routes>
            <Route path="/" element={<SignUp />} />
            <Route path="/signin" element={<SignIn />} />
            <Route path="/home" element={<Home />} />
        </Routes>
    )
}

export default MainRoutes;