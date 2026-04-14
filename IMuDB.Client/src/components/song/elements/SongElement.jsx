function SongElement({clickAction, song }) {
    return (
        <span >{song.track}. <button type="button" className="btn-text" onClick={() => clickAction(song.id)}>{song.name}</button></span>
    )
}

export default SongElement;