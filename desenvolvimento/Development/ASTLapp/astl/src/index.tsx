import React from 'react';
import ReactDOM from 'react-dom/client';
import './Styles/global.css';
import Home from './Pages/Home';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Route } from 'react-router-dom';
import MainRoutes from './Routes/routes';

ReactDOM.createRoot(document.getElementById("root") as HTMLElement).render(
  <BrowserRouter>
    <MainRoutes />
  </BrowserRouter>
);

// const root = ReactDOM.createRoot(
//   document.getElementById('root') as HTMLElement
// );

// root.render(
//   <React.StrictMode>
//     <Home />
//   </React.StrictMode>
// );

// reportWebVitals();
