import { useState } from 'react';
import MusiciansListForm from './MusiciansListForm';

export default function AddUpdateActForm({ onActSubmit }) {
	const [act, setAct] = useState({
		name: '',
		imageUrl: '',
		type: 1,
		musicians: [],
	});

	const nameUpdateHandler = (e) => {
		setAct(
			(a) =>
				(a = {
					...a,
					name: e.target.value,
				}),
		);
	};

	const typeUpdateHandler = (e) => {
		const newActType = parseInt(e.target.value);
		if (!isNaN(newActType)) {
			setAct(
				(a) =>
					(a = {
						...a,
						musicians:
							newActType === 1 ? [act.name] : [...act.musicians],
						type: newActType,
					}),
			);
		}
	};

	const musicianRemoveHandler = (e, i) => {
		setAct(
			(a) =>
				(a = {
					...a,
					musicians: act.musicians.filter(
						(a) => act.musicians.indexOf(a) !== i,
					),
				}),
		);
	};

	const musicianAddHandler = (musician) => {
		const newMusicians = [...act.musicians, musician];
		if (musician.length > 0) {
			setAct({
				...act,
				musicians: newMusicians,
			});
			setMusician('');
		}
	};

	const onSubmit = (e) => {
		e.preventDefault();
		onActSubmit(act);
	};

	return (
		<form
			className=""
			onSubmit={onSubmit}
		>
			<div className="">
				<label
					id="actNameLabel"
					htmlFor="actName"
				>
					Name
				</label>
				<input
					id="actName"
					type="text"
					className="form-input"
					onChange={nameUpdateHandler}
					placeholder="Act Name"
				/>
			</div>
			<div>
				<div>
					<input
						id="typeRadioSolo"
						name="type"
						type="radio"
						className="form-radio"
						value="1"
						onChange={typeUpdateHandler}
					/>
					<label htmlFor="typeRadioSolo">Solo</label>
				</div>
				<div>
					<input
						id="typeRadioBand"
						name="type"
						type="radio"
						className="form-radio"
						value="2"
						onChange={typeUpdateHandler}
					/>
					<label htmlFor="typeRadioBand">Band</label>
				</div>
			</div>
			<div>
				{act.type === 2 && (
					<MusiciansListForm formMusicians={act.musicians} />
				)}
			</div>
			<button
				className="form-button"
				type="submit"
			>
				Save
			</button>
		</form>
	);
}
