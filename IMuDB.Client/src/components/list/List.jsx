function List({ data, renderElement }) {
	return (
		<ul className="list">
			{data.map(d => (
				<li key={d.id} className="list-item">
					{renderElement ? renderElement(d) : d}
				</li>
			))}
		</ul>
	);
}

export default List