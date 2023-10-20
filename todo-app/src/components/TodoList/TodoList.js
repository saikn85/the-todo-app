import "./TodoList.css";
import { TodoCard } from "../TodoCard/TodoCard";
import { useState } from "react";
// The new way of React.js to defining a Component
// The Function Component

const TodoList = () => {
  const [todos, setTodos] = useState([
    {
      title: "ab",
      time: new Date(),
    },
    {
      title: "ac",
      time: new Date(),
    },
    {
      title: "ad",
      time: new Date(),
    },
    {
      title: "aa",
      time: new Date(),
    },
  ]);

  const removeTodo = (todo) => {
    const idx = todos.findIndex(({ title, time }) => title === todo.title);
    todos.splice(idx, 1);
    
    setTodos(todos);
  };

  return (
    <div>
      {todos.map((todo) => (
        <TodoCard key={todo.title} todo={todo} onRemoveTodo={removeTodo} />
      ))}
    </div>
  );
};

export { TodoList };
