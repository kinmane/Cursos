export default function Titulo(info: any) {
  console.log(info);
  return (
    <>
      <h1>{info.principal}</h1>
      <h2>{info.secundario}</h2>
    </>
  )
}