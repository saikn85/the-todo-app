import "./TodoList.css";
import { TodoCard } from "../TodoCard/TodoCard";
// The new way of React.js to defining a Component
// The Function Component

const data = [
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
];

const TodoList = () => {
  return (
    <div>
      {data.map((todo) => (
        <TodoCard todo={todo} />
      ))}
    </div>
  );
};

export { TodoList };
