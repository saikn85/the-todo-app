import './TodoList.css';
// The new way of React.js to defining a Component
// The Function Component
const TodoList = () => {
	return (
		<div>
			<ul>
				<li className="list-style-custom">Test 1</li>
				<li className="list-style-custom">Test 2</li>
				<li className="list-style-custom">Test 3</li>
				<li className="list-style-custom">Test 4</li>
			</ul>
		</div>
	);
};

export { TodoList };
