import React from "react";
import { TodoList } from "./components/TodoList/TodoList";

class App extends React.Component {
  // Render function is the main function, that is responsible
  // for having the UI rendered;
  // That is, HTML + CSS
  // JS gets Bootstrapped upon compilation
  render() {
    return (
      <div>
        <p>Hello World!</p>
        <TodoList />
      </div>
    );
  }
}

export default App;
