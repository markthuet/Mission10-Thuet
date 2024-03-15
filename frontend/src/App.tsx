import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Welcome from "./Heading";
import BowlerList from "./Bowlers/BowlersList";

function App() {
  return (
    <div className="App">
      <Welcome />
      <BowlerList />
    </div>
  );
}

export default App;
