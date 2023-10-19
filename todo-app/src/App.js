import React from "react";
import "./App.css";
import { TodoList } from "./components/TodoList/TodoList";

class App extends React.Component {
  // Render function is the main function, that is responsible
  // for having the UI rendered;
  // That is, HTML + CSS
  // JS gets Bootstrapped upon compilation
  render() {
    return (
      <div className="app-main">
        <section>Header</section>
        <section>Main</section>
        <section>Footer</section>
      </div>
    );
  }
}

export default App;
