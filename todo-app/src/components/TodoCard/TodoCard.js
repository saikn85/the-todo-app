const TodoCard = ({ todo }) => {
  return (
    <div>
      <p>{todo.title}</p>
      <p>{todo.time.toISOString()}</p>
    </div>
  );
};

export { TodoCard };
