import { useState } from 'react';

function MusiciansListForm({ formMusicians, musicianAddHandler, musicianRemoveHandler}) {
    const [musician, setMusician] = useState("");

    const musicianUpdateHandler = (e) => {
        setMusician(e.target.value);
    }

    return (
        <div>
            <label>Musicians</label>
            <input value={musician} onChange={musicianUpdateHandler} />
            <button type="button" onClick={() => musicianAddHandler(musician)}>Add</button>

            {formMusicians &&
                <ul>
                    {formMusicians.map((m, i) => (
                        <li key={i}>
                            {m}
                            <button type="button" onClick={e => musicianRemoveHandler(e, i)}> Remove </button>
                        </li>
                    ))}
                </ul>
            }

        </div>);
}

export default MusiciansListForm;