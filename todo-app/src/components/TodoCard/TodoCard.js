const TodoCard = ({ todo, onRemoveTodo }) => {
  return (
    <div>
      <p>{todo.title}</p>
      <p>{todo.time.toISOString()}</p>
      <button onClick={() => onRemoveTodo(todo)}>remove todo</button>
    </div>
  );
};

export { TodoCard };
