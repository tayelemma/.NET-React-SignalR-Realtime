import React from "react";
import "./App.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home from "./Screens/Home";
import { SignalRContext } from "./SignalR/SignalRContext";
import {singalR} from "../src/SignalR/SignalR"

const App = () => {
  return (
    <SignalRContext.Provider value={singalR()}>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home/>}/>
        </Routes>
      </BrowserRouter>
    </SignalRContext.Provider>
  )
};

export default App;
