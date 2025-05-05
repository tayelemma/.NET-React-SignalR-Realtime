import React from "react";
import "./App.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home from "./Screens/Home";
import { SignalRContext } from "./SignalR/SignalRContext";
import { useSignalR } from "./SignalR/SignalR";

const App = () => {
  const { connection, message } = useSignalR();
  
  return (
    <SignalRContext.Provider value={{connection, message}}>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home/>}/>
        </Routes>
      </BrowserRouter>
    </SignalRContext.Provider>
  )
};

export default App;
